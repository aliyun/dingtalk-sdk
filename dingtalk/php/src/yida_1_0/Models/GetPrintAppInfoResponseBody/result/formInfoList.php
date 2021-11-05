<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintAppInfoResponseBody\result;

use AlibabaCloud\Tea\Model;

class formInfoList extends Model
{
    /**
     * @description formUuid
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description formName
     *
     * @var string
     */
    public $formName;
    protected $_name = [
        'formUuid' => 'formUuid',
        'formName' => 'formName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->formName) {
            $res['formName'] = $this->formName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return formInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['formName'])) {
            $model->formName = $map['formName'];
        }

        return $model;
    }
}
