<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileUploadInfoRequest;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileUploadInfoRequest\option\preCheckParam;
use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 预检查的字段。可实现对文件名称，文件完整性，容量的校验
     *
     * @var preCheckParam
     */
    public $preCheckParam;

    /**
     * @description 优先使用内网传输
     * true
     * @var bool
     */
    public $preferIntranet;

    /**
     * @description 优先地域, 倾向于将资源存到哪个地域，可实现就近上传等功能
     * UNKNOWN: 未知
     * @var string
     */
    public $preferRegion;

    /**
     * @description 文件存储驱动类型, 当前只支持DINGTALK
     * DINGTALK
     * @var string
     */
    public $storageDriver;
    protected $_name = [
        'preCheckParam'  => 'preCheckParam',
        'preferIntranet' => 'preferIntranet',
        'preferRegion'   => 'preferRegion',
        'storageDriver'  => 'storageDriver',
    ];

    public function validate()
    {
    }

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
