<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserAgreementPageSignResponseBody extends Model
{
    /**
     * @description 拉起签约页的字符串
     *
     * @var string
     */
    public $pageData;
    protected $_name = [
        'pageData' => 'pageData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageData) {
            $res['pageData'] = $this->pageData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UserAgreementPageSignResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageData'])) {
            $model->pageData = $map['pageData'];
        }

        return $model;
    }
}
