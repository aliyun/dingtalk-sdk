<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateMiniAppVersionStatusRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 500000003
     *
     * @var string
     */
    public $miniAppId;

    /**
     * @example 0.0.5
     *
     * @var string
     */
    public $version;

    /**
     * @description This parameter is required.
     *
     * @example 0-开发版，1-灰度版，2-发布版，3-体验版
     *
     * @var int
     */
    public $versionType;
    protected $_name = [
        'miniAppId'   => 'miniAppId',
        'version'     => 'version',
        'versionType' => 'versionType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->miniAppId) {
            $res['miniAppId'] = $this->miniAppId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }
        if (null !== $this->versionType) {
            $res['versionType'] = $this->versionType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateMiniAppVersionStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['miniAppId'])) {
            $model->miniAppId = $map['miniAppId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['versionType'])) {
            $model->versionType = $map['versionType'];
        }

        return $model;
    }
}
