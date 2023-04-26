<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\CreateLiveResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 1a353547-040d-4095-bb93-404bc5d47920
     *
     * @var string
     */
    public $liveId;
    protected $_name = [
        'liveId' => 'liveId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveId) {
            $res['liveId'] = $this->liveId;
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
        if (isset($map['liveId'])) {
            $model->liveId = $map['liveId'];
        }

        return $model;
    }
}
