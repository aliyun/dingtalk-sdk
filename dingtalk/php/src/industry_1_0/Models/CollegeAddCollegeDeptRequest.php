<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeAddCollegeDeptRequest extends Model
{
    /**
     * @example 三年二班
     *
     * @var string
     */
    public $deptName;

    /**
     * @example class
     *
     * @var string
     */
    public $deptType;

    /**
     * @example 10
     *
     * @var int
     */
    public $sortFactor;

    /**
     * @example 22222
     *
     * @var int
     */
    public $superId;
    protected $_name = [
        'deptName'   => 'deptName',
        'deptType'   => 'deptType',
        'sortFactor' => 'sortFactor',
        'superId'    => 'superId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }
        if (null !== $this->sortFactor) {
            $res['sortFactor'] = $this->sortFactor;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeAddCollegeDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['sortFactor'])) {
            $model->sortFactor = $map['sortFactor'];
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }

        return $model;
    }
}
