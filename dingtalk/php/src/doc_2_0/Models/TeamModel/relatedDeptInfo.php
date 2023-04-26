<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\TeamModel;

use AlibabaCloud\Tea\Model;

class relatedDeptInfo extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $deptId;

    /**
     * @example 测试部门
     *
     * @var string
     */
    public $deptName;
    protected $_name = [
        'deptId'   => 'deptId',
        'deptName' => 'deptName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relatedDeptInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }

        return $model;
    }
}
