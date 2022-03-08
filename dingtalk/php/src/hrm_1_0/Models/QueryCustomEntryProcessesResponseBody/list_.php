<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\QueryCustomEntryProcessesResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $formDesc;

    /**
     * @var string
     */
    public $formId;

    /**
     * @var string
     */
    public $formName;

    /**
     * @var string
     */
    public $shortUrl;
    protected $_name = [
        'formDesc' => 'formDesc',
        'formId'   => 'formId',
        'formName' => 'formName',
        'shortUrl' => 'shortUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formDesc) {
            $res['formDesc'] = $this->formDesc;
        }
        if (null !== $this->formId) {
            $res['formId'] = $this->formId;
        }
        if (null !== $this->formName) {
            $res['formName'] = $this->formName;
        }
        if (null !== $this->shortUrl) {
            $res['shortUrl'] = $this->shortUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formDesc'])) {
            $model->formDesc = $map['formDesc'];
        }
        if (isset($map['formId'])) {
            $model->formId = $map['formId'];
        }
        if (isset($map['formName'])) {
            $model->formName = $map['formName'];
        }
        if (isset($map['shortUrl'])) {
            $model->shortUrl = $map['shortUrl'];
        }

        return $model;
    }
}
