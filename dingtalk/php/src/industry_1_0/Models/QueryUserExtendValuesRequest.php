<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserExtendValuesRequest extends Model
{
    /**
     * @description 组织id
     *
     * @var int
     */
    public $dingOrgId;

    /**
     * @description userId列表
     *
     * @var string[]
     */
    public $userIds;

    /**
     * @description 用户拓展key
     *
     * @var string
     */
    public $userExtendKey;
    protected $_name = [
        'dingOrgId'     => 'dingOrgId',
        'userIds'       => 'userIds',
        'userExtendKey' => 'userExtendKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->userExtendKey) {
            $res['userExtendKey'] = $this->userExtendKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserExtendValuesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['userExtendKey'])) {
            $model->userExtendKey = $map['userExtendKey'];
        }

        return $model;
    }
}
