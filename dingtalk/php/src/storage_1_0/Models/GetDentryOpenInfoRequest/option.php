<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetDentryOpenInfoRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $checkLogin;

    /**
     * @example PREVIEW
     *
     * @var string
     */
    public $type;

    /**
     * @example 1
     *
     * @var int
     */
    public $version;

    /**
     * @example true
     *
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
