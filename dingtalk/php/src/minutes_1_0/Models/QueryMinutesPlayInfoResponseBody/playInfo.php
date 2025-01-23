<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesPlayInfoResponseBody;

use AlibabaCloud\Tea\Model;

class playInfo extends Model
{
    /**
     * @var string
     */
    public $downloadUrl;

    /**
     * @var string
     */
    public $duration;

    /**
     * @var string
     */
    public $mediaType;

    /**
     * @var string
     */
    public $playUrl;

    /**
     * @var string
     */
    public $size;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'downloadUrl' => 'downloadUrl',
        'duration'    => 'duration',
        'mediaType'   => 'mediaType',
        'playUrl'     => 'playUrl',
        'size'        => 'size',
        'status'      => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->mediaType) {
            $res['mediaType'] = $this->mediaType;
        }
        if (null !== $this->playUrl) {
            $res['playUrl'] = $this->playUrl;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return playInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['mediaType'])) {
            $model->mediaType = $map['mediaType'];
        }
        if (isset($map['playUrl'])) {
            $model->playUrl = $map['playUrl'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
