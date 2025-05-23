<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileUploadInfoRequest;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileUploadInfoRequest\option\preCheckParam;
use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @var preCheckParam
     */
    public $preCheckParam;

    /**
     * @example true
     *
     * @var bool
     */
    public $preferIntranet;

    /**
     * @example ZHANGJIAKOU
     *
     * @var string
     */
    public $preferRegion;

    /**
     * @example DINGTALK
     *
     * @var string
     */
    public $storageDriver;
    protected $_name = [
        'preCheckParam' => 'preCheckParam',
        'preferIntranet' => 'preferIntranet',
        'preferRegion' => 'preferRegion',
        'storageDriver' => 'storageDriver',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->preCheckParam) {
            $res['preCheckParam'] = null !== $this->preCheckParam ? $this->preCheckParam->toMap() : null;
        }
        if (null !== $this->preferIntranet) {
            $res['preferIntranet'] = $this->preferIntranet;
        }
        if (null !== $this->preferRegion) {
            $res['preferRegion'] = $this->preferRegion;
        }
        if (null !== $this->storageDriver) {
            $res['storageDriver'] = $this->storageDriver;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['preCheckParam'])) {
            $model->preCheckParam = preCheckParam::fromMap($map['preCheckParam']);
        }
        if (isset($map['preferIntranet'])) {
            $model->preferIntranet = $map['preferIntranet'];
        }
        if (isset($map['preferRegion'])) {
            $model->preferRegion = $map['preferRegion'];
        }
        if (isset($map['storageDriver'])) {
            $model->storageDriver = $map['storageDriver'];
        }

        return $model;
    }
}
