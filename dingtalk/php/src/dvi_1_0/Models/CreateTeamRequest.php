<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTeamRequest extends Model
{
    /**
     * @var string[]
     */
    public $adminUserIds;

    /**
     * @var int[]
     */
    public $deptIds;

    /**
     * @var string
     */
    public $dialectCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $sceneCodes;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $solutionCode;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'adminUserIds' => 'adminUserIds',
        'deptIds' => 'deptIds',
        'dialectCode' => 'dialectCode',
        'name' => 'name',
        'sceneCodes' => 'sceneCodes',
        'solutionCode' => 'solutionCode',
        'userIds' => 'userIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->adminUserIds) {
            $res['adminUserIds'] = $this->adminUserIds;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->dialectCode) {
            $res['dialectCode'] = $this->dialectCode;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sceneCodes) {
            $res['sceneCodes'] = $this->sceneCodes;
        }
        if (null !== $this->solutionCode) {
            $res['solutionCode'] = $this->solutionCode;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTeamRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adminUserIds'])) {
            if (!empty($map['adminUserIds'])) {
                $model->adminUserIds = $map['adminUserIds'];
            }
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['dialectCode'])) {
            $model->dialectCode = $map['dialectCode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sceneCodes'])) {
            if (!empty($map['sceneCodes'])) {
                $model->sceneCodes = $map['sceneCodes'];
            }
        }
        if (isset($map['solutionCode'])) {
            $model->solutionCode = $map['solutionCode'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
