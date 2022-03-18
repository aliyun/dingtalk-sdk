<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetRelationUkSettingResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 查重字段的bizAlias
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @description 查重字段的字段id
     *
     * @var string
     */
    public $fieldId;
    protected $_name = [
        'bizAlias' => 'bizAlias',
        'fieldId'  => 'fieldId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }

        return $model;
    }
}
