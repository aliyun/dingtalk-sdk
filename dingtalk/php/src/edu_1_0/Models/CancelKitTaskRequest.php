<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CancelKitTaskRequest extends Model
{
    /**
     * @example CARD_EVENT
     *
     * @var string
     */
    public $bizType;

    /**
     * @example ding12123
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2023234234234
     *
     * @var string
     */
    public $identifier;

    /**
     * @example CHENZHI
     *
     * @var string
     */
    public $isvCode;
    protected $_name = [
        'bizType' => 'bizType',
        'corpId' => 'corpId',
        'identifier' => 'identifier',
        'isvCode' => 'isvCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->identifier) {
            $res['identifier'] = $this->identifier;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CancelKitTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['identifier'])) {
            $model->identifier = $map['identifier'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }

        return $model;
    }
}
