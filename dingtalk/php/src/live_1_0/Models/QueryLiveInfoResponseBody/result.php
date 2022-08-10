<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveInfoResponseBody\result\liveInfo;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var liveInfo
     */
    public $liveInfo;
    protected $_name = [
        'liveInfo' => 'liveInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveInfo) {
            $res['liveInfo'] = null !== $this->liveInfo ? $this->liveInfo->toMap() : null;
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
        if (isset($map['liveInfo'])) {
            $model->liveInfo = liveInfo::fromMap($map['liveInfo']);
        }

        return $model;
    }
}
