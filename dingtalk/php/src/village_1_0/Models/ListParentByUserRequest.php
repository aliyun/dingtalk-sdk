<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListParentByUserRequest extends Model
{
    /**
     * @description 下属组织的组织ID，比如下属镇、村的corpId
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description 用户userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'subCorpId' => 'subCorpId',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListParentByUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
