<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerAuthInfoResponseBody\result\authInfo;

use AlibabaCloud\Tea\Model;

class mainCorp extends Model
{
    /**
     * @var bool
     */
    public $authorized;

    /**
     * @var string
     */
    public $corpName;
    protected $_name = [
        'authorized' => 'authorized',
        'corpName'   => 'corpName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authorized) {
            $res['authorized'] = $this->authorized;
        }
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mainCorp
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authorized'])) {
            $model->authorized = $map['authorized'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }

        return $model;
    }
}
