<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCloudRecordVideoPlayInfoResponseBody extends Model
{
    /**
     * @description 时长
     *
     * @var int
     */
    public $duration;

    /**
     * @description 大小
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description MP4格式下载链接
     *
     * @var string
     */
    public $mp4FileUrl;

    /**
     * @description 在线播放链接
     *
     * @var string
     */
    public $playUrl;

    /**
     * @description 状态
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'duration'   => 'duration',
        'fileSize'   => 'fileSize',
        'mp4FileUrl' => 'mp4FileUrl',
        'playUrl'    => 'playUrl',
        'status'     => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->mp4FileUrl) {
            $res['mp4FileUrl'] = $this->mp4FileUrl;
        }
        if (null !== $this->playUrl) {
            $res['playUrl'] = $this->playUrl;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCloudRecordVideoPlayInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['mp4FileUrl'])) {
            $model->mp4FileUrl = $map['mp4FileUrl'];
        }
        if (isset($map['playUrl'])) {
            $model->playUrl = $map['playUrl'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
