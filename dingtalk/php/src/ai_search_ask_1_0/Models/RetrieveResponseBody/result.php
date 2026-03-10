<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\calendars;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\dingHelperDocs;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\docs;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\faqs;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\finalResults;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\minutes;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\reports;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\wikis;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var calendars[]
     */
    public $calendars;

    /**
     * @var dingHelperDocs[]
     */
    public $dingHelperDocs;

    /**
     * @var docs[]
     */
    public $docs;

    /**
     * @var faqs[]
     */
    public $faqs;

    /**
     * @var finalResults[]
     */
    public $finalResults;

    /**
     * @var minutes[]
     */
    public $minutes;

    /**
     * @var reports[]
     */
    public $reports;

    /**
     * @var wikis[]
     */
    public $wikis;
    protected $_name = [
        'calendars' => 'calendars',
        'dingHelperDocs' => 'dingHelperDocs',
        'docs' => 'docs',
        'faqs' => 'faqs',
        'finalResults' => 'finalResults',
        'minutes' => 'minutes',
        'reports' => 'reports',
        'wikis' => 'wikis',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->calendars) {
            $res['calendars'] = [];
            if (null !== $this->calendars && \is_array($this->calendars)) {
                $n = 0;
                foreach ($this->calendars as $item) {
                    $res['calendars'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->dingHelperDocs) {
            $res['dingHelperDocs'] = [];
            if (null !== $this->dingHelperDocs && \is_array($this->dingHelperDocs)) {
                $n = 0;
                foreach ($this->dingHelperDocs as $item) {
                    $res['dingHelperDocs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->docs) {
            $res['docs'] = [];
            if (null !== $this->docs && \is_array($this->docs)) {
                $n = 0;
                foreach ($this->docs as $item) {
                    $res['docs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->faqs) {
            $res['faqs'] = [];
            if (null !== $this->faqs && \is_array($this->faqs)) {
                $n = 0;
                foreach ($this->faqs as $item) {
                    $res['faqs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->finalResults) {
            $res['finalResults'] = [];
            if (null !== $this->finalResults && \is_array($this->finalResults)) {
                $n = 0;
                foreach ($this->finalResults as $item) {
                    $res['finalResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->minutes) {
            $res['minutes'] = [];
            if (null !== $this->minutes && \is_array($this->minutes)) {
                $n = 0;
                foreach ($this->minutes as $item) {
                    $res['minutes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->reports) {
            $res['reports'] = [];
            if (null !== $this->reports && \is_array($this->reports)) {
                $n = 0;
                foreach ($this->reports as $item) {
                    $res['reports'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->wikis) {
            $res['wikis'] = [];
            if (null !== $this->wikis && \is_array($this->wikis)) {
                $n = 0;
                foreach ($this->wikis as $item) {
                    $res['wikis'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['calendars'])) {
            if (!empty($map['calendars'])) {
                $model->calendars = [];
                $n = 0;
                foreach ($map['calendars'] as $item) {
                    $model->calendars[$n++] = null !== $item ? calendars::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['dingHelperDocs'])) {
            if (!empty($map['dingHelperDocs'])) {
                $model->dingHelperDocs = [];
                $n = 0;
                foreach ($map['dingHelperDocs'] as $item) {
                    $model->dingHelperDocs[$n++] = null !== $item ? dingHelperDocs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['docs'])) {
            if (!empty($map['docs'])) {
                $model->docs = [];
                $n = 0;
                foreach ($map['docs'] as $item) {
                    $model->docs[$n++] = null !== $item ? docs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['faqs'])) {
            if (!empty($map['faqs'])) {
                $model->faqs = [];
                $n = 0;
                foreach ($map['faqs'] as $item) {
                    $model->faqs[$n++] = null !== $item ? faqs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['finalResults'])) {
            if (!empty($map['finalResults'])) {
                $model->finalResults = [];
                $n = 0;
                foreach ($map['finalResults'] as $item) {
                    $model->finalResults[$n++] = null !== $item ? finalResults::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['minutes'])) {
            if (!empty($map['minutes'])) {
                $model->minutes = [];
                $n = 0;
                foreach ($map['minutes'] as $item) {
                    $model->minutes[$n++] = null !== $item ? minutes::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['reports'])) {
            if (!empty($map['reports'])) {
                $model->reports = [];
                $n = 0;
                foreach ($map['reports'] as $item) {
                    $model->reports[$n++] = null !== $item ? reports::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['wikis'])) {
            if (!empty($map['wikis'])) {
                $model->wikis = [];
                $n = 0;
                foreach ($map['wikis'] as $item) {
                    $model->wikis[$n++] = null !== $item ? wikis::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
