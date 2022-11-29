<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetFileDownloadInfoRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 优先使用内网传输
     * true
     * @var bool
     */
    public $preferIntranet;

    /**
     * @description 历史版本号
     *
     * @var int
     */
    public $version;
    protected $_name = [
        'preferIntranet' => 'preferIntranet',
        'version'        => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->preferIntranet) {
            $res['preferIntranet'] = $this->preferIntranet;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
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
        if (isset($map['preferIntranet'])) {
            $model->preferIntranet = $map['preferIntranet'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
