<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetOpenCourseDetailResponseBody;

use AlibabaCloud\Tea\Model;

class pushModel extends Model
{
    /**
     * @description 参与学校的名称列表
     *
     * @var string[]
     */
    public $pushOrgNameList;

    /**
     * @description 参与角色的名称列表
     *
     * @var string[]
     */
    public $pushRoleNameList;
    protected $_name = [
        'pushOrgNameList'  => 'pushOrgNameList',
        'pushRoleNameList' => 'pushRoleNameList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pushOrgNameList) {
            $res['pushOrgNameList'] = $this->pushOrgNameList;
        }
        if (null !== $this->pushRoleNameList) {
            $res['pushRoleNameList'] = $this->pushRoleNameList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pushModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pushOrgNameList'])) {
            if (!empty($map['pushOrgNameList'])) {
                $model->pushOrgNameList = $map['pushOrgNameList'];
            }
        }
        if (isset($map['pushRoleNameList'])) {
            if (!empty($map['pushRoleNameList'])) {
                $model->pushRoleNameList = $map['pushRoleNameList'];
            }
        }

        return $model;
    }
}
