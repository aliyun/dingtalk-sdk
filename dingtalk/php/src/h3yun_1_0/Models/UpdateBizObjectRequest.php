<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateBizObjectRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ceeb5ad3-b6da-4d4d-b6a5-8d342567d189
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @description This parameter is required.
     *
     * @example {     "F0000010": "0001111",     "F0000011": "王五",     "F0000012": "D1级客户",     "F0000013": 7000,     "D000183Fcd15f3a51e624bbc9945392d190b6aa8": [         {             "F0000014": "里斯",             "F0000015": "156********",             "F0000016": "技术部",             "F0000017": "经理",             "F0000018": "男",             "F0000019": "lgbxunmi@dd.com",             "F0000020": true,             "F0000021": "无"         }     ] }
     *
     * @var string
     */
    public $bizObjectJson;

    /**
     * @description This parameter is required.
     *
     * @example D0001839bbbbe346bbf496498bb76c44c7eb972
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectId'   => 'bizObjectId',
        'bizObjectJson' => 'bizObjectJson',
        'schemaCode'    => 'schemaCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjectId) {
            $res['bizObjectId'] = $this->bizObjectId;
        }
        if (null !== $this->bizObjectJson) {
            $res['bizObjectJson'] = $this->bizObjectJson;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateBizObjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizObjectId'])) {
            $model->bizObjectId = $map['bizObjectId'];
        }
        if (isset($map['bizObjectJson'])) {
            $model->bizObjectJson = $map['bizObjectJson'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
