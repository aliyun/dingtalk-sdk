<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetOrgLiveListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetOrgLiveListResponseBody\result\newLive;
use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetOrgLiveListResponseBody\result\updateLive;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var newLive
     */
    public $newLive;

    /**
     * @var updateLive
     */
    public $updateLive;
    protected $_name = [
        'newLive'    => 'newLive',
        'updateLive' => 'updateLive',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->newLive) {
            $res['newLive'] = null !== $this->newLive ? $this->newLive->toMap() : null;
        }
        if (null !== $this->updateLive) {
            $res['updateLive'] = null !== $this->updateLive ? $this->updateLive->toMap() : null;
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
        if (isset($map['newLive'])) {
            $model->newLive = newLive::fromMap($map['newLive']);
        }
        if (isset($map['updateLive'])) {
            $model->updateLive = updateLive::fromMap($map['updateLive']);
        }

        return $model;
    }
}
