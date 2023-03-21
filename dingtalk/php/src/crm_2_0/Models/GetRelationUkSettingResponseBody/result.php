<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_2_0\Models\GetRelationUkSettingResponseBody\result\formUkSettings;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var formUkSettings[]
     */
    public $formUkSettings;

    /**
     * @description 查重列表表头字段id列表。
     *
     * @var string[]
     */
    public $headerFieldIds;
    protected $_name = [
        'formUkSettings' => 'formUkSettings',
        'headerFieldIds' => 'headerFieldIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formUkSettings) {
            $res['formUkSettings'] = [];
            if (null !== $this->formUkSettings && \is_array($this->formUkSettings)) {
                $n = 0;
                foreach ($this->formUkSettings as $item) {
                    $res['formUkSettings'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->headerFieldIds) {
            $res['headerFieldIds'] = $this->headerFieldIds;
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
        if (isset($map['formUkSettings'])) {
            if (!empty($map['formUkSettings'])) {
                $model->formUkSettings = [];
                $n                     = 0;
                foreach ($map['formUkSettings'] as $item) {
                    $model->formUkSettings[$n++] = null !== $item ? formUkSettings::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['headerFieldIds'])) {
            if (!empty($map['headerFieldIds'])) {
                $model->headerFieldIds = $map['headerFieldIds'];
            }
        }

        return $model;
    }
}
