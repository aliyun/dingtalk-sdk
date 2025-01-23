<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryUploadVideoPlayInfoResponseBody\playInfo;
use AlibabaCloud\Tea\Model;

class QueryUploadVideoPlayInfoResponseBody extends Model
{
    /**
     * @var playInfo
     */
    public $playInfo;
    protected $_name = [
        'playInfo' => 'playInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->playInfo) {
            $res['playInfo'] = null !== $this->playInfo ? $this->playInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUploadVideoPlayInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['playInfo'])) {
            $model->playInfo = playInfo::fromMap($map['playInfo']);
        }

        return $model;
    }
}
