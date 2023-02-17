<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListProgressByIdsRequest extends Model
{
    /**
     * @description 进展ID列表
     *
     * @var string[]
     */
    public $progressIds;
    protected $_name = [
        'progressIds' => 'progressIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->progressIds) {
            $res['progressIds'] = $this->progressIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListProgressByIdsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['progressIds'])) {
            if (!empty($map['progressIds'])) {
                $model->progressIds = $map['progressIds'];
            }
        }

        return $model;
    }
}
