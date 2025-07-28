<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody\approvalSummary;

use AlibabaCloud\Tea\Model;

class title extends Model
{
    /**
     * @example zhangsan
     *
     * @var string
     */
    public $enUS;

    /**
     * @example i18n
     *
     * @var string
     */
    public $type;

    /**
     * @example 张三
     *
     * @var string
     */
    public $zhCN;
    protected $_name = [
        'enUS' => 'en_US',
        'type' => 'type',
        'zhCN' => 'zh_CN',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enUS) {
            $res['en_US'] = $this->enUS;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->zhCN) {
            $res['zh_CN'] = $this->zhCN;
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
        if (isset($map['en_US'])) {
            $model->enUS = $map['en_US'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['zh_CN'])) {
            $model->zhCN = $map['zh_CN'];
        }

        return $model;
    }
}
