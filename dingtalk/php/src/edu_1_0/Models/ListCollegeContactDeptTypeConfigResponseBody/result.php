<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\ListCollegeContactDeptTypeConfigResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example contact_class_dept
     *
     * @var string
     */
    public $deptType;

    /**
     * @example 班级
     *
     * @var string
     */
    public $name;

    /**
     * @var bool
     */
    public $userDef;
    protected $_name = [
        'deptType' => 'deptType',
        'name'     => 'name',
        'userDef'  => 'userDef',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userDef) {
            $res['userDef'] = $this->userDef;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userDef'])) {
            $model->userDef = $map['userDef'];
        }

        return $model;
    }
}
