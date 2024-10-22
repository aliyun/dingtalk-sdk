<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteBookingBlacklistRequest extends Model
{
    /**
     * @var string[]
     */
    public $blacklistUnionIds;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'blacklistUnionIds' => 'blacklistUnionIds',
        'unionId'           => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blacklistUnionIds) {
            $res['blacklistUnionIds'] = $this->blacklistUnionIds;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteBookingBlacklistRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blacklistUnionIds'])) {
            if (!empty($map['blacklistUnionIds'])) {
                $model->blacklistUnionIds = $map['blacklistUnionIds'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
