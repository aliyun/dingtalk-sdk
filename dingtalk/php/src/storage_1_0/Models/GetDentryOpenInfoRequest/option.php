<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryOpenInfoRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 是否检查钉钉登录态, 目前仅对预览生效。
     * false
     * @var bool
     */
    public $checkLogin;

    /**
     * @description 打开方式，可以分为预览和编辑
     * PREVIEW
     * @var string
     */
    public $type;

    /**
     * @description 历史版本号, 不填表示最新版本
     *
     * @var int
     */
    public $version;

    /**
     * @description 是否需要水印
     * false
     * @var bool
     */
    public $waterMark;
    protected $_name = [
        'checkLogin' => 'checkLogin',
        'type'       => 'type',
        'version'    => 'version',
        'waterMark'  => 'waterMark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->checkLogin) {
            $res['checkLogin'] = $this->checkLogin;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }
        if (null !== $this->waterMark) {
            $res['waterMark'] = $this->waterMark;
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
        if (isset($map['checkLogin'])) {
            $model->checkLogin = $map['checkLogin'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }
        if (isset($map['waterMark'])) {
            $model->waterMark = $map['waterMark'];
        }

        return $model;
    }
}
