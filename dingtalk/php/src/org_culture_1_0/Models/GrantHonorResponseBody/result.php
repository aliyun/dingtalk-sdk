<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\GrantHonorResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 失败的userId
     *
     * @var string[]
     */
    public $failedUserIds;

    /**
     * @description 成功的userId
     *
     * @var string[]
     */
    public $successUserIds;
    protected $_name = [
        'failedUserIds'  => 'failedUserIds',
        'successUserIds' => 'successUserIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->failedUserIds) {
            $res['failedUserIds'] = $this->failedUserIds;
        }
        if (null !== $this->successUserIds) {
            $res['successUserIds'] = $this->successUserIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failedUserIds'])) {
            if (!empty($map['failedUserIds'])) {
                $model->failedUserIds = $map['failedUserIds'];
            }
        }
        if (isset($map['successUserIds'])) {
            if (!empty($map['successUserIds'])) {
                $model->successUserIds = $map['successUserIds'];
            }
        }

        return $model;
    }
}
