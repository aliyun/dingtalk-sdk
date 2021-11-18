<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class SaveCorpPayCodeResponseBody extends Model
{
    /**
     * @description 码标识
     *
     * @var string
     */
    public $codeIdentity;

    /**
     * @description 开通的企业ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 状态
     *
     * @var string
     */
    public $status;

    /**
     * @description 扩展参数
     *
     * @var string[]
     */
    public $extInfo;
    protected $_name = [
        'codeIdentity' => 'codeIdentity',
        'corpId'       => 'corpId',
        'status'       => 'status',
        'extInfo'      => 'extInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->codeIdentity) {
            $res['codeIdentity'] = $this->codeIdentity;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveCorpPayCodeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['codeIdentity'])) {
            $model->codeIdentity = $map['codeIdentity'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }

        return $model;
    }
}
