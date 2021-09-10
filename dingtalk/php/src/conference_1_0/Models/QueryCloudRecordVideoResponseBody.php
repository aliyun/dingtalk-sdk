<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordVideoResponseBody\videoList;
use AlibabaCloud\Tea\Model;

class QueryCloudRecordVideoResponseBody extends Model
{
    /**
     * @description 视频列表
     *
     * @var videoList[]
     */
    public $videoList;
    protected $_name = [
        'videoList' => 'videoList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->videoList) {
            $res['videoList'] = [];
            if (null !== $this->videoList && \is_array($this->videoList)) {
                $n = 0;
                foreach ($this->videoList as $item) {
                    $res['videoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCloudRecordVideoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['videoList'])) {
            if (!empty($map['videoList'])) {
                $model->videoList = [];
                $n                = 0;
                foreach ($map['videoList'] as $item) {
                    $model->videoList[$n++] = null !== $item ? videoList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
