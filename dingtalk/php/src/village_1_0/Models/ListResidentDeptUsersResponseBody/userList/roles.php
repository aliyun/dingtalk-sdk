<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentDeptUsersResponseBody\userList;

use AlibabaCloud\Tea\Model;

class roles extends Model
{
    /**
     * @description 标签id
     *
     * @var int
     */
    public $tagId;

    /**
     * @description 标签名称
     *
     * @var string
     */
    public $tagName;

    /**
     * @description 标签名称 tagCode
     *
     * @var string
     */
    public $tagCode;
    protected $_name = [
        'tagId'   => 'tagId',
        'tagName' => 'tagName',
        'tagCode' => 'tagCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tagId) {
            $res['tagId'] = $this->tagId;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
        }
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tagId'])) {
            $model->tagId = $map['tagId'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }

        return $model;
    }
}
