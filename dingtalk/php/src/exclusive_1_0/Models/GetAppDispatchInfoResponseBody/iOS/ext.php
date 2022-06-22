<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetAppDispatchInfoResponseBody\iOS;

use AlibabaCloud\Tea\Model;

class ext extends Model
{
    /**
     * @description plist下载地址
     *
     * @var string
     */
    public $plist;
    protected $_name = [
        'plist' => 'plist',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->plist) {
            $res['plist'] = $this->plist;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ext
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['plist'])) {
            $model->plist = $map['plist'];
        }

        return $model;
    }
}
