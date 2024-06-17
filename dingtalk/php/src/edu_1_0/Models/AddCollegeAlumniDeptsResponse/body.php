<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeAlumniDeptsResponse;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var int
     */
    public $deptId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $superId;

    /**
     * @var bool
     */
    public $hasSubDept;

    /**
     * @var string
     */
    public $deptType;
    protected $_name = [
        'corpId'     => 'corpId',
        'deptId'     => 'deptId',
        'name'       => 'name',
        'superId'    => 'superId',
        'hasSubDept' => 'hasSubDept',
        'deptType'   => 'deptType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
        }
        if (null !== $this->hasSubDept) {
            $res['hasSubDept'] = $this->hasSubDept;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }
        if (isset($map['hasSubDept'])) {
            $model->hasSubDept = $map['hasSubDept'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }

        return $model;
    }
}
