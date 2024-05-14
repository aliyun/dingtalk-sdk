<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppHistoryVersionResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 0-打包中 ，1-成功，2-失败
     *
     * @var int
     */
    public $buildStatus;

    /**
     * @description This parameter is required.
     *
     * @example https://xxx.con/download/id
     *
     * @var string
     */
    public $h5Bundle;

    /**
     * @description This parameter is required.
     *
     * @example 5000
     *
     * @var string
     */
    public $packageSize;

    /**
     * @description This parameter is required.
     *
     * @example https://xxx.con/download/id
     *
     * @var string
     */
    public $packageUrl;

    /**
     * @description This parameter is required.
     *
     * @example 0.0.5
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'buildStatus' => 'buildStatus',
        'h5Bundle'    => 'h5Bundle',
        'packageSize' => 'packageSize',
        'packageUrl'  => 'packageUrl',
        'version'     => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->buildStatus) {
            $res['buildStatus'] = $this->buildStatus;
        }
        if (null !== $this->h5Bundle) {
            $res['h5Bundle'] = $this->h5Bundle;
        }
        if (null !== $this->packageSize) {
            $res['packageSize'] = $this->packageSize;
        }
        if (null !== $this->packageUrl) {
            $res['packageUrl'] = $this->packageUrl;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['buildStatus'])) {
            $model->buildStatus = $map['buildStatus'];
        }
        if (isset($map['h5Bundle'])) {
            $model->h5Bundle = $map['h5Bundle'];
        }
        if (isset($map['packageSize'])) {
            $model->packageSize = $map['packageSize'];
        }
        if (isset($map['packageUrl'])) {
            $model->packageUrl = $map['packageUrl'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
