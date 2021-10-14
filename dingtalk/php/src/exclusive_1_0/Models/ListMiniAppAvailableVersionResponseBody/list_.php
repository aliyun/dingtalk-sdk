<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\ListMiniAppAvailableVersionResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 打包状态，0-打包中，1-成功，2-失败
     *
     * @var int
     */
    public $buildStatus;

    /**
     * @description 版本
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'buildStatus' => 'buildStatus',
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
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
