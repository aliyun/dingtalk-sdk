<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetPrintAppInfoResponseBody\result;

use AlibabaCloud\Tea\Model;

class formInfoList extends Model
{
    /**
     * @description formName
     *
     * @var string
     */
    public $formName;

    /**
     * @description formUuid
     *
     * @var string
     */
    public $formUuid;
    protected $_name = [
        'formName' => 'formName',
        'formUuid' => 'formUuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formName) {
            $res['formName'] = $this->formName;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
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
        if (isset($map['formName'])) {
            $model->formName = $map['formName'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }

        return $model;
    }
}
