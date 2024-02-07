<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverWithDelegateRequest;

use AlibabaCloud\Tea\Model;

class topOpenDeliverModel extends Model
{
    /**
     * @example 1665473229000
     *
     * @var int
     */
    public $expiredTimeMillis;

    /**
     * @var string[]
     */
    public $platforms;

    /**
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
