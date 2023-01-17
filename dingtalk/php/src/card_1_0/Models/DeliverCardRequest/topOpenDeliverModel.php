<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\DeliverCardRequest;

use AlibabaCloud\Tea\Model;

class topOpenDeliverModel extends Model
{
    /**
     * @description 【必填】过期时间戳
     *
     * @var int
     */
    public $expiredTimeMillis;

    /**
     * @description 可以查看该吊顶卡片的设备
     *
     * @var string[]
     */
    public $platforms;

    /**
     * @description 可以查看该吊顶卡片的staffId
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'expiredTimeMillis' => 'expiredTimeMillis',
        'platforms'         => 'platforms',
        'userIds'           => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->expiredTimeMillis) {
            $res['expiredTimeMillis'] = $this->expiredTimeMillis;
        }
        if (null !== $this->platforms) {
            $res['platforms'] = $this->platforms;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return topOpenDeliverModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expiredTimeMillis'])) {
            $model->expiredTimeMillis = $map['expiredTimeMillis'];
        }
        if (isset($map['platforms'])) {
            if (!empty($map['platforms'])) {
                $model->platforms = $map['platforms'];
            }
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
