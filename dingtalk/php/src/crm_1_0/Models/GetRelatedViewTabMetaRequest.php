<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRelatedViewTabMetaRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example PROC-2DB0FF86-CE29-41FF-B0FE-BFDE5BD9A0C1
     *
     * @var string
     */
    public $formCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $viewUserId;
    protected $_name = [
        'formCode'   => 'formCode',
        'viewUserId' => 'viewUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->viewUserId) {
            $res['viewUserId'] = $this->viewUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRelatedViewTabMetaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['viewUserId'])) {
            $model->viewUserId = $map['viewUserId'];
        }

        return $model;
    }
}
