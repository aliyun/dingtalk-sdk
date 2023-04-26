<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterDeviceRequest\devices;

use AlibabaCloud\Tea\Model;

class liveUrls extends Model
{
    /**
     * @example https://abc.stream.flv
     *
     * @var string
     */
    public $flv;

    /**
     * @example https://abc.stream.m3u8
     *
     * @var string
     */
    public $hls;

    /**
     * @example rtmp://abc.stream
     *
     * @var string
     */
    public $rtmp;
    protected $_name = [
        'flv'  => 'flv',
        'hls'  => 'hls',
        'rtmp' => 'rtmp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->flv) {
            $res['flv'] = $this->flv;
        }
        if (null !== $this->hls) {
            $res['hls'] = $this->hls;
        }
        if (null !== $this->rtmp) {
            $res['rtmp'] = $this->rtmp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return liveUrls
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['flv'])) {
            $model->flv = $map['flv'];
        }
        if (isset($map['hls'])) {
            $model->hls = $map['hls'];
        }
        if (isset($map['rtmp'])) {
            $model->rtmp = $map['rtmp'];
        }

        return $model;
    }
}
