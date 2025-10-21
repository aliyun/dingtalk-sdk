<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAudioFileInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example A1
     *
     * @var string
     */
    public $deviceType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileId;
    protected $_name = [
        'deviceType' => 'deviceType',
        'fileId' => 'fileId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceType) {
            $res['deviceType'] = $this->deviceType;
        }
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAudioFileInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceType'])) {
            $model->deviceType = $map['deviceType'];
        }
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }

        return $model;
    }
}
