<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\GetLoginUserResponseBody;

use AlibabaCloud\Tea\Model;

class commodityInfo extends Model
{
    /**
     * @var string
     */
    public $version;
    protected $_name = [
        'version' => 'version',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return commodityInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
