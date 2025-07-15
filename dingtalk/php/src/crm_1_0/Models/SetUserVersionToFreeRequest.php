<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetUserVersionToFreeRequest extends Model
{
    /**
     * @example 012829186736-1115677667
     *
     * @var string
     */
    public $operatorUserId;

    /**
     * @example other
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'operatorUserId' => 'operatorUserId',
        'version' => 'version',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetUserVersionToFreeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
