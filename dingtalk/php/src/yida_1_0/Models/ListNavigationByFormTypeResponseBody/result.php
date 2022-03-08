<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListNavigationByFormTypeResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListNavigationByFormTypeResponseBody\result\title;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description formUuid
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description processCode
     *
     * @var string
     */
    public $processCode;

    /**
     * @description title
     *
     * @var title
     */
    public $title;
    protected $_name = [
        'formUuid'    => 'formUuid',
        'processCode' => 'processCode',
        'title'       => 'title',
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
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }
        if (null !== $this->title) {
            $res['title'] = null !== $this->title ? $this->title->toMap() : null;
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
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }
        if (isset($map['title'])) {
            $model->title = title::fromMap($map['title']);
        }

        return $model;
    }
}
