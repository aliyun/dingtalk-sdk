<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoResponseBody\confInfo;
use AlibabaCloud\Tea\Model;

class QueryConferenceInfoResponseBody extends Model
{
    /**
     * @description 会议信息结构体
     *
     * @var confInfo
     */
    public $confInfo;
    protected $_name = [
        'confInfo' => 'confInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->confInfo) {
            $res['confInfo'] = null !== $this->confInfo ? $this->confInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryConferenceInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['confInfo'])) {
            $model->confInfo = confInfo::fromMap($map['confInfo']);
        }

        return $model;
    }
}
