<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAppDispatchInfoResponseBody;

use AlibabaCloud\Tea\Model;

class mac extends Model
{
    /**
     * @description 基线版本
     *
     * @var string
     */
    public $baseLineVersion;

    /**
     * @description 下载地址
     *
     * @var string
     */
    public $downloadUrl;

    /**
     * @description 是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布
     *
     * @var bool
     */
    public $inGray;

    /**
     * @description 打包时间
     *
     * @var int
     */
    public $packTime;

    /**
     * @description 客户端类型
     *
     * @var string
     */
    public $platform;

    /**
     * @description 版本号
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'baseLineVersion' => 'baseLineVersion',
        'downloadUrl'     => 'downloadUrl',
        'inGray'          => 'inGray',
        'packTime'        => 'packTime',
        'platform'        => 'platform',
        'version'         => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->baseLineVersion) {
            $res['baseLineVersion'] = $this->baseLineVersion;
        }
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->inGray) {
            $res['inGray'] = $this->inGray;
        }
        if (null !== $this->packTime) {
            $res['packTime'] = $this->packTime;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mac
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['baseLineVersion'])) {
            $model->baseLineVersion = $map['baseLineVersion'];
        }
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['inGray'])) {
            $model->inGray = $map['inGray'];
        }
        if (isset($map['packTime'])) {
            $model->packTime = $map['packTime'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
