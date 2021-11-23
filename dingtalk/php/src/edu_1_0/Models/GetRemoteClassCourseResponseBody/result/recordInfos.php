<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetRemoteClassCourseResponseBody\result;

use AlibabaCloud\Tea\Model;

class recordInfos extends Model
{
    /**
     * @description 录制文件地址（文件有效期7天）
     *
     * @var string
     */
    public $url;

    /**
     * @description 录制开始时间（UTC/GMT格式）
     *
     * @var string
     */
    public $startTime;

    /**
     * @description 录制结束时间（UTC/GMT格式）
     *
     * @var string
     */
    public $stopTime;
    protected $_name = [
        'url'       => 'url',
        'startTime' => 'startTime',
        'stopTime'  => 'stopTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->stopTime) {
            $res['stopTime'] = $this->stopTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recordInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['stopTime'])) {
            $model->stopTime = $map['stopTime'];
        }

        return $model;
    }
}
