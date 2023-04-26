<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDownloadInfoRequest extends Model
{
    /**
     * @var string
     */
    public $unionId;

    /**
     * @var bool
     */
    public $withInternalResourceUrl;

    /**
     * @var bool
     */
    public $withRegion;
    protected $_name = [
        'unionId'                 => 'unionId',
        'withInternalResourceUrl' => 'withInternalResourceUrl',
        'withRegion'              => 'withRegion',
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
        if (null !== $this->withInternalResourceUrl) {
            $res['withInternalResourceUrl'] = $this->withInternalResourceUrl;
        }
        if (null !== $this->withRegion) {
            $res['withRegion'] = $this->withRegion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDownloadInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['withInternalResourceUrl'])) {
            $model->withInternalResourceUrl = $map['withInternalResourceUrl'];
        }
        if (isset($map['withRegion'])) {
            $model->withRegion = $map['withRegion'];
        }

        return $model;
    }
}
