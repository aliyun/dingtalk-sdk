<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPreviewInfoRequest extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;

    /**
     * @var int
     */
    public $version;

    /**
     * @var bool
     */
    public $watermark;
    protected $_name = [
        'unionId'   => 'unionId',
        'version'   => 'version',
        'watermark' => 'watermark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }
        if (null !== $this->watermark) {
            $res['watermark'] = $this->watermark;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPreviewInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['watermark'])) {
            $model->watermark = $map['watermark'];
        }

        return $model;
    }
}
