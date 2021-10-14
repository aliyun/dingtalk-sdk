<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPayAccountListRequest extends Model
{
    /**
     * @description Isv coprId
     *
     * @var string
     */
    public $isvCorpId;

    /**
     * @description 应用suiteId
     *
     * @var string
     */
    public $suiteId;

    /**
     * @description 组织corpId
     *
     * @var string
     */
    public $corpId;
    protected $_name = [
        'isvCorpId' => 'isvCorpId',
        'suiteId'   => 'suiteId',
        'corpId'    => 'corpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isvCorpId) {
            $res['isvCorpId'] = $this->isvCorpId;
        }
        if (null !== $this->suiteId) {
            $res['suiteId'] = $this->suiteId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPayAccountListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isvCorpId'])) {
            $model->isvCorpId = $map['isvCorpId'];
        }
        if (isset($map['suiteId'])) {
            $model->suiteId = $map['suiteId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }

        return $model;
    }
}
