<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListUserGroupsRequest extends Model
{
    /**
     * @var string
     */
    public $groupType;

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
        'groupType' => 'groupType',
        'offset' => 'offset',
        'size' => 'size',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
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
     * @return ListUserGroupsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
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
