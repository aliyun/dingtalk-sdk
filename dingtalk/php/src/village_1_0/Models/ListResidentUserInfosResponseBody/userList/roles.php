<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentUserInfosResponseBody\userList;

use AlibabaCloud\Tea\Model;

class roles extends Model
{
    /**
     * @description 标签名称 tagCode
     *
     * @var string
     */
    public $tagCode;

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
    protected $_name = [
        'tagCode' => 'tagCode',
        'tagId'   => 'tagId',
        'tagName' => 'tagName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tagCode) {
            $res['tagCode'] = $this->tagCode;
        }
        if (null !== $this->tagId) {
            $res['tagId'] = $this->tagId;
        }
        if (null !== $this->tagName) {
            $res['tagName'] = $this->tagName;
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
        if (isset($map['tagCode'])) {
            $model->tagCode = $map['tagCode'];
        }
        if (isset($map['tagId'])) {
            $model->tagId = $map['tagId'];
        }
        if (isset($map['tagName'])) {
            $model->tagName = $map['tagName'];
        }

        return $model;
    }
}
