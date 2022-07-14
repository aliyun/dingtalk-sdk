<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\PageFormBaseInfosResponseBody\result\data;

use AlibabaCloud\Tea\Model;

class title extends Model
{
    /**
     * @var string
     */
    public $enUS;

    /**
     * @var string
     */
    public $zhCN;
    protected $_name = [
        'enUS' => 'enUS',
        'zhCN' => 'zhCN',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->enUS) {
            $res['enUS'] = $this->enUS;
        }
        if (null !== $this->zhCN) {
            $res['zhCN'] = $this->zhCN;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return title
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enUS'])) {
            $model->enUS = $map['enUS'];
        }
        if (isset($map['zhCN'])) {
            $model->zhCN = $map['zhCN'];
        }

        return $model;
    }
}
