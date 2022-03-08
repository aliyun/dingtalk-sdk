<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminiapp_1_0\Models\ListAvaiableVersionResponseBody;

use AlibabaCloud\Tea\Model;

class versions extends Model
{
    /**
     * @var int
     */
    public $buildStatus;

    /**
     * @var string
     */
    public $h5Bundle;

    /**
     * @var string
     */
    public $packageSize;

    /**
     * @var string
     */
    public $packageUrl;

    /**
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
     * @return versions
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
