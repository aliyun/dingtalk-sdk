<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReportDeviceLogRequest extends Model
{
    /**
     * @example xdfsf20001
     *
     * @var string
     */
    public $mediaId;

    /**
     * @example sn123
     *
     * @var string
     */
    public $sn;

    /**
     * @example file：普通文件
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'mediaId' => 'mediaId',
        'sn'      => 'sn',
        'type'    => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReportDeviceLogRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
