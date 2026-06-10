<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\ListUserGroupsResponseBody\result;

use AlibabaCloud\Tea\Model;

class groups extends Model
{
    /**
     * @var int
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $groupCode;

    /**
     * @var string
     */
    public $groupType;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'gmtModified' => 'gmtModified',
        'groupCode' => 'groupCode',
        'groupType' => 'groupType',
        'name' => 'name',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->groupCode) {
            $res['groupCode'] = $this->groupCode;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groups
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['groupCode'])) {
            $model->groupCode = $map['groupCode'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
