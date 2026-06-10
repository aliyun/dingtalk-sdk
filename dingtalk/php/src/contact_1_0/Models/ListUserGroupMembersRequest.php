<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListUserGroupMembersRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $groupCode;

    /**
     * @var int
     */
    public $offset;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'groupCode' => 'groupCode',
        'offset' => 'offset',
        'size' => 'size',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupCode) {
            $res['groupCode'] = $this->groupCode;
        }
        if (null !== $this->offset) {
            $res['offset'] = $this->offset;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListUserGroupMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupCode'])) {
            $model->groupCode = $map['groupCode'];
        }
        if (isset($map['offset'])) {
            $model->offset = $map['offset'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
