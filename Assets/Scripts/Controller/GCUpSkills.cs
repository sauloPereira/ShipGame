using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCUpSkills : MonoBehaviour {

    public void Ups() {

        var listSkills = FindObjectsOfType<GCShop>();

        foreach (var skill in listSkills) {
            skill.Ok();
        }

    }

}
