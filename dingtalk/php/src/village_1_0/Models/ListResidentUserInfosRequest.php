<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListResidentUserInfosRequest extends Model
{
    /**
     * @description 下属组织的组织ID，比如下属镇、村的corpId
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description 用户id列表
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'subCorpId' => 'subCorpId',
        'userIds'   => 'userIds',
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
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListResidentUserInfosRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
